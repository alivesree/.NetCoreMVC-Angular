import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MasterRoutingModule } from './master-routing.module';
import { TestComponent } from './test/test.component';
import { Test1Component } from './test1/test1.component';

@NgModule({
  declarations: [TestComponent, Test1Component],
  imports: [
    CommonModule,
    MasterRoutingModule
  ]
})
export class MasterModule { }
