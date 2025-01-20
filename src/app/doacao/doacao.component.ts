import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule, MatIconRegistry } from '@angular/material/icon';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-doacao',
  standalone: true,
  imports: [CommonModule,
            MatIconModule
  ],
  templateUrl: './doacao.component.html',
  styleUrls: ['./doacao.component.css'],
})
export class DoacaoComponent {
  constructor(private iconRegistry: MatIconRegistry, private sanitizer: DomSanitizer) {
    this.iconRegistry.addSvgIcon(
      'botao-laranja', 
      sanitizer.bypassSecurityTrustResourceUrl('assets/botao-laranja.svg')
    );
  }
}
