import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LayoutRoutingModule } from './layout-routing.module';
import { LayoutComponent } from './layout.component';
import { LeftComponent } from '../outer/left/left.component';
import { HeaderComponent } from '../outer/header/header.component';
import { FooterComponent } from '../outer/footer/footer.component';

@NgModule({
  declarations: [LayoutComponent,
    LeftComponent,
    HeaderComponent,
    FooterComponent],
  imports: [
    CommonModule,
    LayoutRoutingModule
  ]
})
export class LayoutModule { }
