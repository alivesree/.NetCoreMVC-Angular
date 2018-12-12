import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {LayoutComponent} from './layout.component';

const routes: Routes = [{
  // { path: '', component:LayoutComponent},
  // children:[
    
  // ]
  // {path:'master',loadChildren:'./master/master.module#MasterModule'}

  ////////
  path: '',
      component:LayoutComponent,
        children:[
          { path:'master', loadChildren:'./master/master.module#MasterModule'},
       ]
      }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutRoutingModule { }
