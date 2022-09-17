import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Addres_bookComponent } from './Addres_book.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [Addres_bookComponent],
  exports:[Addres_bookComponent]
})
export class Addres_bookModule { }
