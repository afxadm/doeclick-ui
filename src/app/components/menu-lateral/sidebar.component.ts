import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css'],
})
export class SidebarComponent {
  constructor(private router: Router) {}

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
