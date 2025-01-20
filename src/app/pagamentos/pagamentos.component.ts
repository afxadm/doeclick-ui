import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule, MatIconRegistry } from '@angular/material/icon';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-pagamentos',
  standalone: true,
  imports: [CommonModule,
            MatIconModule
  ],
  templateUrl: './pagamentos.component.html',
  styleUrls: ['./pagamentos.component.css'],
})
export class PagamentosComponent {
  constructor(private iconRegistry: MatIconRegistry, private sanitizer: DomSanitizer) {
    const icons = [
      { name: 'pagamentos', url: 'assets/botao-pagamentos.svg' },
      { name: 'congregacoes', url: 'assets/botao-congregacoes.svg' },
      { name: 'contribuicoes', url: 'assets/botao-contribuicoes.svg' },
      { name: 'obreiros', url: 'assets/botao-obreiros.svg' }
    ];
    icons.forEach(icon => {
      this.iconRegistry.addSvgIcon(
        icon.name,
        this.sanitizer.bypassSecurityTrustResourceUrl(icon.url)
      );
    });
  }
}