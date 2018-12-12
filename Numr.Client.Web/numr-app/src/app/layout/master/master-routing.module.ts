import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {TestComponent} from './test/test.component';
import {Test1Component} from './test1/test1.component';

const routes: Routes = [
  { path:'',component:TestComponent},
  { path:'test',component:TestComponent},
  { path:'test1',component:Test1Component},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MasterRoutingModule { }
