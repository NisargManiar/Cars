import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CarsComponent } from './Cars/cars/cars.component';
import { UsersComponent } from './Users/users/users.component';


const routes: Routes = [

  { path: 'Cars', component: CarsComponent },
  { path: 'Regiter', component: UsersComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
