import { Routes } from '@angular/router';
import { CausaComponent } from './causa/causa.component';
import { DoacaoComponent } from './doacao/doacao.component';
import { UsuarioComponent } from './usuario/usuario.component';
import { ContribuinteComponent } from './contribuinte/contribuinte.component';
import { CausaAdmComponent } from './causa-adm/causa-adm.component';
import { ListaUsuarioComponent } from './lista-usuario/lista-usuario.component';
import { ListaCausaAdmComponent } from './lista-causa-adm/lista-causa-adm.component';
import { ListaContribuinteComponent } from './lista-contribuinte/lista-contribuinte.component';
import { LoginComponent } from './login/login.component';
import { ContribuicoesComponent } from './contribuicoes/contribuicoes.component';
import { IdentificacaoComponent } from './identificacao/identificacao.component';
import { InformarValorComponent } from './informarValor/informarValor.component';
import { CodIgrejaComponent } from './codIgreja/codIgreja.component';
import { CongregacoesComponent } from './congregacoes/congregacoes.component';
import { PagamentosComponent } from './pagamentos/pagamentos.component';
import { CarrinhoComponent } from './carrinho/carrinho.component';


export const routes: Routes = [
  { path: '', component: DoacaoComponent },
  { path: 'causa', component: CausaComponent },
  { path: 'contribuicoes', component: ContribuicoesComponent },
  { path: 'identificacao', component: IdentificacaoComponent },
  { path: 'informarValor', component: InformarValorComponent },
  { path: 'codIgreja', component: CodIgrejaComponent },
  { path: 'congregacoes', component: CongregacoesComponent },
  { path: 'pagamentos', component: PagamentosComponent },
  { path: 'carrinho', component: CarrinhoComponent },
  { path: 'usuario', component: UsuarioComponent},
  { path: 'lista-usuario', component: ListaUsuarioComponent},
  { path: 'contribuinte', component: ContribuinteComponent},
  { path: 'lista-contribuinte', component: ListaContribuinteComponent},
  { path: 'causa-adm', component: CausaAdmComponent},
  { path: 'lista-causa-adm', component: ListaCausaAdmComponent},
  { path: 'login', component: LoginComponent},
  { path: '**', redirectTo: '' }
];
