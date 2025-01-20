import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-causa-adm',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './causa-adm.component.html',
  styleUrls: ['./causa-adm.component.css']
})
export class CausaAdmComponent {
  form: FormGroup;
  contribuicaoSemMeta: boolean = false;
  contribuicaoComMeta: boolean = false;
  pagamento: boolean = false;
  titulo: string = '';

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      tipo_causa: [this.titulo, Validators.required], // SelectBox
      descricao: ['', [Validators.required, Validators.maxLength(100)]], // Text
      ativo: ['true', Validators.required], // Radio Button
      observacoes: ['', [Validators.required, Validators.maxLength(100)]], // Text
      meta_valor: ['', [Validators.required, Validators.pattern(/^\d+(\.\d{1,2})?$/)]], // Number com decimal
      data_final: ['', Validators.required], // Date
      valor: ['', [Validators.required, Validators.pattern(/^\d+(\.\d{1,2})?$/)]], // Number com decimal
      data_final_validade: ['', Validators.required] // Date
    });
  }

  onSubmit() {
    if (this.form.valid) {
      console.log(this.form.value);
    }
  }

  public escolherModalidade(event: Event): void {
    const value = (event.target as HTMLSelectElement).value;
  
    this.contribuicaoSemMeta = false;
    this.contribuicaoComMeta = false;
    this.pagamento = false;
  
    if (value === 'contribuicaoSemMeta') {
      this.contribuicaoSemMeta = true;
      this.titulo = "Contribuição sem meta"
      console.log(this.contribuicaoSemMeta, this.contribuicaoComMeta, this.pagamento)
    } else if (value === 'contribuicaoComMeta') {
      this.contribuicaoComMeta = true;
      this.titulo = "Contribuição com meta"
    } else {
      this.pagamento = true;
      this.titulo = "Pagamento"
    }
  }
  
}
