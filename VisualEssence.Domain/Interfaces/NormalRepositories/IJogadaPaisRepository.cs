﻿using VisualEssence.Domain.DTOs;
using VisualEssence.Domain.DTOs.GamesDTO;
using VisualEssence.Domain.Interfaces.GenericRepository;
using VisualEssence.Domain.Models.Jogada;

namespace VisualEssence.Domain.Interfaces.NormalRepositories
{
    public interface IJogadaPaisRepository : IRepository<JogadaPais, JogadaPaisDTO>
    {
        Task<IEnumerable<HistoricoJogadasDTO>> ObterHistoricoPorNomeJogo(string nomeJogo, Guid userId);
    }
}
