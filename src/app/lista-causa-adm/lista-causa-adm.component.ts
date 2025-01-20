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
  selector: 'app-causa-adm',
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
  templateUrl: './lista-causa-adm.component.html',
  styleUrls: ['./lista-causa-adm.component.css'],
})
export class ListaCausaAdmComponent {
  displayedColums = ['id', 'descricao', 'tipo', 'ativo', 'acoes'];

  listaUsuario: any[] = [
    { id: '1', descricao: 'Carro do lelinho', tipo: 'Contribuição sem meta',  ativo: true },
    { id: '2', descricao: 'Viagem do lelinho', tipo: 'Contribuição sem meta',  ativo: false },
    { id: '3', descricao: 'Restaurantes para o lelinho', tipo: 'Contribuição com meta',  ativo: true },
    { id: '4', descricao: 'Doação livre pro lelinho', tipo: 'Pagamento',  ativo: false },
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

