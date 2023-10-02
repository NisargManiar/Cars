import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';

@Component({
  selector: 'app-show-cars',
  templateUrl: './show-cars.component.html',
  styleUrls: ['./show-cars.component.css']
})
export class ShowCarsComponent implements OnInit {

  constructor(private service: ApiserviceService) { }

  CarsList: any = [];
  ModalTitle = "";
  ActivateAddEdiCars: boolean = false;
  Cars: any;


  ngOnInit(): void {
  }
  addClick() {
    this.Cars = {
      Brand: "",
      Model:"",
      Year:"",
      Price:"",
      New:"",
    }
    this.ModalTitle = "Add Cars";
    this.ActivateAddEdiCars = true;
  }

  editClick(item: any) {
    this.Cars = item;
    this.ModalTitle = "Edit Cars";
    this.ActivateAddEdiCars = true;
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.service.deleteCars(item.CarId).subscribe(data => {
        alert(data.toString());
        this.refreshDepList();
      })
    }
  }

  closeClick() {
    this.ActivateAddEdiCars = false;
    this.refreshDepList();
  }


  refreshDepList() {
    this.service.getCarsList().subscribe(data => {
      this.CarsList = data;
    });
  }
}
