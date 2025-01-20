import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import {FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators} from '@angular/forms';
import {MatRadioModule} from '@angular/material/radio';

@Component({
  selector: 'app-usuario',
  standalone: true,
  imports: [CommonModule,
            MatInputModule,
            FormsModule,
            MatFormFieldModule,
            MatRadioModule,
            ReactiveFormsModule
  ],
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent {

  form: FormGroup;

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      nome: ['', Validators.required, Validators.maxLength(100)],
      telefone: ['', [Validators.required, Validators.pattern(/^\d+$/), Validators.maxLength(15)]],
      email: ['', [Validators.required, Validators.email, Validators.maxLength(60)]],
      cargo: ['', Validators.required, Validators.maxLength(30)],
      ativo: ['true', Validators.required] // Campo rádio com opção de ativo
    });
  }

  onSubmit() {
    if (this.form.valid) {
      console.log(this.form.value);
    }
  }
}
