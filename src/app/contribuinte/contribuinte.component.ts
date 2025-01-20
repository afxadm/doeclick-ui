import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import {FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators} from '@angular/forms';
import {MatRadioModule} from '@angular/material/radio';

@Component({
  selector: 'app-contribuinte',
  standalone: true,
  imports: [CommonModule,
            MatInputModule,
            FormsModule,
            MatFormFieldModule,
            MatRadioModule,
            ReactiveFormsModule
  ],
  templateUrl: './contribuinte.component.html',
  styleUrls: ['./contribuinte.component.css']
})
export class ContribuinteComponent {

  form: FormGroup;

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      nome: ['', Validators.maxLength(100)],
      telefone: ['', [ Validators.pattern(/^\d+$/), Validators.maxLength(15)]],
      cargo: ['', Validators.maxLength(30)],
      ativo: ['true', ] // Campo rádio com opção de ativo
    });
  }

  onSubmit() {
    if (this.form.valid) {
      console.log(this.form.value);
    }
  }
}
