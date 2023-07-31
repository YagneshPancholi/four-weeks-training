import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LoginComponent} from '../app/cmp/login/login.component'
import { AppComponent } from './app.component';

const routes: Routes = [
  {path:'', component:AppComponent}, 
  {path:'login', component:LoginComponent},
  { path: '**', redirectTo: '/app' },
  { path: 'home', redirectTo: '/app' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
