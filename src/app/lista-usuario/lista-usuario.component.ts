import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormBuilder, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatRadioModule } from '@angular/material/radio';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { SidebarComponent } from '../components/menu-lateral/sidebar.component';

@Component({
  selector: 'app-lista-usuario',
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
  templateUrl: './lista-usuario.component.html',
  styleUrls: ['./lista-usuario.component.css'],
})
export class ListaUsuarioComponent {
  displayedColums = ['id', 'nome', 'email', 'cargo', 'telefone', 'ativo', 'acoes'];

  listaUsuario: any[] = [
    { id: '1', nome: 'João', email: 'joao@joao.com', telefone: '(11) 99999-9999', cargo: 'Atendente', ativo: true },
    { id: '2', nome: 'Jose', email: 'jose@jose.com', telefone: '(11) 99999-9999', cargo: 'Assistente', ativo: false },
    { id: '3', nome: 'Jamil', email: 'jamil@jamil.com', telefone: '(11) 99999-9999', cargo: 'Dono', ativo: true },
    { id: '4', nome: 'Jamal', email: 'jamal@jamal.com', telefone: '(11) 99999-9999', cargo: 'Atendente', ativo: false },
  ];

  constructor(private fb: FormBuilder) {}

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
}

