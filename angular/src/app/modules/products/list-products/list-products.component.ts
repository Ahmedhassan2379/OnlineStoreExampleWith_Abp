import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common'
import { ProductDto, ProductService } from '@proxy/products';
import { PagedAndSortedResultRequestDto } from '@abp/ng.core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-list-products',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './list-products.component.html',
  styleUrl: './list-products.component.scss'
})
export class ListProductsComponent implements OnInit {
  products :ProductDto[]=[];
  input:PagedAndSortedResultRequestDto={sorting:'',maxResultCount:10,skipCount:0}
  constructor(private productService:ProductService,private router:Router){

  }
  ngOnInit(): void {
    this.productService.getProductList(this.input).subscribe((result) => {
      this.products = result.items
    });
  }

  addProduct() {
    this.router.navigateByUrl('/products/add');
  }
}
