import { Component, Input, OnInit } from '@angular/core';
import { IProduct } from 'src/app/shared/Models/products';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.scss']
})
export class ProductItemComponent implements OnInit {

  @Input()
  product: IProduct
    = {
    id: 0,
    name: '',
    description: '',
    price: 0,
    pictureUrl: '',
    productType: '',
    productBrand: ''
  };
  constructor() { }

  ngOnInit(): void {
  }

}
