﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using VisualEssence.Domain.DTOs;
using VisualEssence.Domain.Interfaces;
using VisualEssence.Domain.Models;
using VisualEssenceAPI.Services;

namespace VisualEssence.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly string _secretKey;
        private readonly IUsuarioInstRepository _usuarioInstRepository;
        private readonly CadastroInst _cadastroInst;
        private readonly IUsuarioPaisRepository _usuarioPaisRepository;
        private readonly CadastroPais _cadastroPais;

        public AuthController(string secretKey, IUsuarioInstRepository usuarioInstRepository, CadastroInst cadastroInst, IUsuarioPaisRepository usuarioPaisRepository, CadastroPais cadastroPais)
        {
            _secretKey = secretKey;
            _usuarioInstRepository = usuarioInstRepository;
            _cadastroInst = cadastroInst;
            _usuarioPaisRepository = usuarioPaisRepository;
            _cadastroPais = cadastroPais;
        }

        [HttpGet("UsersInst")]
        public async Task<IActionResult> GetInst()
        {
            var users = await _usuarioInstRepository.GetUser();
            return Ok(users);
        }

        [HttpGet("UsersPais")]
        public async Task<IActionResult> GetPais()
        {
            var users = await _usuarioPaisRepository.GetUser();
            return Ok(users);
        }

        [HttpPost("cadastro-inst")]
        public async Task<IActionResult> Register(UserInst userInst)
        {
            if (await _usuarioInstRepository.UsuarioExistente(userInst.Email))
            {
                return BadRequest(new { Message = "Email ja cadastrado" });
            }

            var uInstDto = new UserInstDTO
            {
                NomeInst = userInst.NomeInst,
                Email = userInst.Email,
                CNPJ = userInst.CNPJ,
                Senha = userInst.Senha,
            };

            await _cadastroInst.ExcetuteAsyncs(uInstDto);
            return Ok(new { Message = "Usuario registrado com sucesso" });
        }

        [HttpPost("login-inst")]
        public async Task<IActionResult> Login(InstLoginRequest loginRequest)
        {
            var usuario = await _usuarioInstRepository.GetUsuarioInstByEmail(loginRequest.EmailInst);

            if (usuario == null || !BCrypt.Net.BCrypt.Verify(loginRequest.Senha, usuario.Senha))
            {
                return Unauthorized(new { Message = "Credenciais Invalidas" });
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new { Token = tokenString });
        }

        [HttpPost("cadastro-pais")]
        public async Task<IActionResult> Register(UserPais userPais)
        {
            if (await _usuarioPaisRepository.UsuarioExistente(userPais.Email))
            {
                return BadRequest(new { Message = "Email ja cadastrado" });
            }

            var uPaisDto = new UserPaisDTO
            {
                Nome = userPais.Nome,
                Email = userPais.Email,
                Senha = userPais.Senha,
            };

            await _cadastroPais.ExcetuteAsyncs(uPaisDto);
            return Ok(new { Message = "Usuario registrado com sucesso" });
        }

        [HttpPost("login-pais")]
        public async Task<IActionResult> Login(PLoginRequest loginRequest)
        {
            var usuario = await _usuarioPaisRepository.GetUsuarioByEmail(loginRequest.Email);

            if (usuario == null || !BCrypt.Net.BCrypt.Verify(loginRequest.Senha, usuario.Senha))
            {
                return Unauthorized(new { Message = "Credenciais Invalidas" });
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new { Token = tokenString });
        }

        [HttpGet("pais/{id}")]
        public async Task<ActionResult> GetPaisById(Guid id)
        {
            var usuario = await _usuarioPaisRepository.GetUsuarioById(id);
    
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpGet("instituicao/{id}")]
        public async Task<ActionResult> GetIntById(Guid id)
        {
            var usuario = await _usuarioInstRepository.GetUsuarioById(id);

            if (usuario == null) return NotFound();
            return Ok(usuario);
        }
    }
}
