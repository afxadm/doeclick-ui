import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormBuilder, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatRadioModule } from '@angular/material/radio';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { Router } from '@angular/router';
import { SidebarComponent } from '../components/menu-lateral/sidebar.component';

@Component({
  selector: 'app-contribuinte',
  standalone: true,
  imports: [
    CommonModule,
    MatInputModule,
    FormsModule,
    MatFormFieldModule,
    MatRadioModule,
    ReactiveFormsModule,
    MatTableModule,
    MatButtonModule,
    MatIconModule,
    SidebarComponent
  ],
  templateUrl: './lista-contribuinte.component.html',
  styleUrls: ['./lista-contribuinte.component.css'],
})
export class ListaContribuinteComponent {
  displayedColums = ['id', 'nome', 'cargo', 'telefone', 'ativo', 'acoes'];

  listaUsuario: any[] = [
    { id: '1', nome: 'João',  telefone: '(11) 99999-9999', cargo: 'Atendente', ativo: true },
    { id: '2', nome: 'Jose', telefone: '(11) 99999-9999', cargo: 'Assistente', ativo: false },
    { id: '3', nome: 'Jamil',  telefone: '(11) 99999-9999', cargo: 'Dono', ativo: true },
    { id: '4', nome: 'Jamal',  telefone: '(11) 99999-9999', cargo: 'Atendente', ativo: false },
  ];

  constructor( private router: Router) {}

  visualizarUsuario(usuario: any): void {
    console.log('Editar usuário:', usuario);
    // Lógica para editar o usuário
  }

  editarUsuario(usuario: any): void {
    console.log('Editar usuário:', usuario);
    // Lógica para editar o usuário
  }

  deletarUsuario(usuario: any): void {
    console.log('Deletar usuário:', usuario);
    // Lógica para deletar o usuário
  }


  navegarParaListaUsuario() {
    this.router.navigate(['/lista-usuario']);
  }

  navegarParaListaContribuinte() {
    this.router.navigate(['/lista-contribuinte']);
  }

  navegarParaListaCausaAdm() {
    this.router.navigate(['/lista-causa-adm']);
  }

  navegarCheckout() {
    this.router.navigate(['']);
  }


}

