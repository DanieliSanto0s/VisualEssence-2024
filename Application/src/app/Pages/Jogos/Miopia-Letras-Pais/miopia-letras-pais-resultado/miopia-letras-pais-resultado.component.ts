import { Component } from '@angular/core';
import { MiopiaGameService } from '../../Miopia/Services/miopia-game.service';
import { AuthService } from '../../../../../Services/Auth/AuthService/auth.service';
import { JogadaPais } from '../../../../Models/MiopiaGame/jogadaPais.model';
import { MiopiaResult } from '../../../../Models/MiopiaGame/miopiaResult.model';
import { CriancaPais } from '../../../../Models/MiopiaGame/criancapais.model';
import { LogoMenuComponent } from "../../../SharedMenu/logo-menu/logo-menu.component";
import { NgIf } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-miopia-letras-pais-resultado',
  standalone: true,
  imports: [LogoMenuComponent, NgIf, RouterLink],
  templateUrl: './miopia-letras-pais-resultado.component.html',
  styleUrl: './miopia-letras-pais-resultado.component.css'
})
export class MiopiaLetrasPaisResultadoComponent {
  result: MiopiaResult;
  userPaisId =  String(this.authService.getUserIdFromToken())

  jogada: JogadaPais = {
    NomeJogo: "Miopia Letras",
    idCrianca: '',
    pontuacao: 0,
    userPaisId: this.userPaisId
  };

  constructor(private gameService: MiopiaGameService, private authService: AuthService) {
    this.result = history.state.data;
  }

  ngOnInit(): void {
    if (this.result) {
      this.jogada.pontuacao = this.result.score;
      this.processGameResult();
    }
    console.log('userid>', this.userPaisId);

  }

  processGameResult(): void {
    const nomeCrianca = localStorage.getItem("nomeCriancaPais");
    const idadeCrianca = localStorage.getItem("idadeCriancaPais");

    if (nomeCrianca && idadeCrianca) {
      const novaCrianca: CriancaPais = {
        nome: nomeCrianca,
        idade: Number(idadeCrianca),
        userPaisId: this.userPaisId
      };

      this.gameService.cadastrarCrianca(novaCrianca).subscribe(
        criancaResponse => {
          console.log('Criança cadastrada com sucesso:', criancaResponse);
          this.jogada.idCrianca = criancaResponse.id ?? '';
          this.addNewJogada();
        },
        error => {
          console.error('Não foi possível registrar a criança', error);
        }
      );
    } else {
      console.error('Dados da criança não encontrados no localStorage.');
    }
  }

  addNewJogada(): void {
    if (this.jogada.idCrianca) {
      this.gameService.addJogada(this.jogada).subscribe(
        response => {
          console.log('Jogada adicionada com sucesso', response);
        },
        error => {
          console.error('Não foi possível adicionar a jogada', error);
        }
      );
    } else {
      console.error('ID da criança não encontrado.');
    }
  }
}
