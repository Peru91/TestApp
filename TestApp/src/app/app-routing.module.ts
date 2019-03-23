import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserModuleComponent } from './user-module/user-module.component';
import { AppComponent } from './app.component';
import { AuthGuard } from './auth/auth.guard';

const routes: Routes = [
  {path: '', redirectTo: '', pathMatch: 'full'},
  {path: 'user', component: UserModuleComponent, pathMatch: 'full'},
  {path: 'home', component: AppComponent, canActivate:[AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
