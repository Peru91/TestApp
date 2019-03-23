import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { httpInterceptorProviders } from './http-interceptors/index';
import {AuthModule} from './../app/auth/auth.module';
import { UserModuleComponent } from './user-module/user-module.component';


@NgModule({
  declarations: [
    AppComponent,
    UserModuleComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AuthModule,
    HttpClientModule
  ],
  providers: [
    httpInterceptorProviders
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
