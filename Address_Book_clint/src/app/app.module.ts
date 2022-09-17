import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Addres_bookModule } from './Addres_book/Addres_book.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    Addres_bookModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
