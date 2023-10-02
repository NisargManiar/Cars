import { Component, Input, OnInit } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';

@Component({
  selector: 'app-add-edit-cars',
  templateUrl: './add-edit-cars.component.html',
  styleUrls: ['./add-edit-cars.component.css']
})
export class AddEditCarsComponent implements OnInit {

  constructor(private service: ApiserviceService) { }
  @Input() Cars: any;
  Brand= "";
  Model="";
  Year="";
  Price="";
  New="";
  ngOnInit(): void {
    this.Brand = this.Cars.Brand;
    this.Model = this.Cars.Model;
    this.Year = this.Cars.Year;
    this.Price = this.Cars.Price;
    this.New = this.Cars.New;
  }
  

  addCars() {
   
    var Cars = {
      Brand: this.Brand,
      Model:this.Model ,
      Year:this.Year,
      Price: this.Price,
      New:this.New,
    }
    this.service.addCars(Cars).subscribe(res => {
      alert(res.toString());
    });
  }

  updateCars() {
    var Cars = {
      Brand: this.Brand,
      Model:this.Model ,
      Year:this.Year,
      Price: this.Price,
      New:this.New,
    }
    this.service.updateCars(Cars).subscribe(res => {
      alert(res.toString());
    });
  }

}
