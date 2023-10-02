import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './Components/navbar/navbar/navbar.component';
import { UsersComponent } from './Users/users/users.component';
import { CarsComponent } from './Cars/cars/cars.component';
import { AddEditCarsComponent } from './Cars/cars/add-edit-cars/add-edit-cars.component';
import { ShowCarsComponent } from './Cars/cars/show-cars/show-cars.component';
import { ApiserviceService } from './apiservice.service';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    UsersComponent,
    CarsComponent,
    AddEditCarsComponent,
    ShowCarsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [ApiserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
