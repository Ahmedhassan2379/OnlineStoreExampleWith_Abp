import { PagedAndSortedResultRequestDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CategoryService } from '@proxy/categories';
import { CategoryDto } from '@proxy/dtos';
import { CreateOrUpdateProductDto, ProductService } from '@proxy/products';

@Component({
  selector: 'app-add-product',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.scss'
})
export class AddProductComponent implements OnInit {

  productForm: FormGroup
  categories :CategoryDto[]=[];
  input:PagedAndSortedResultRequestDto={sorting:'',maxResultCount:10,skipCount:0}
  constructor(private productService: ProductService,
    private categoryService: CategoryService,
    private router: Router,
    private fb: FormBuilder) {
    this.buildForm();
  }
  ngOnInit(): void {
    this.categoryService.getList(this.input).subscribe((response)=>{
      this.categories=response.items;
      console.log(response)
    })
  }
  buildForm() {
    this.productForm = this.fb.group({
      nameAr: new FormControl('', [Validators.required, Validators.maxLength(300)]),
      nameEn: new FormControl('', [Validators.required, Validators.maxLength(300)]),
      descriptionAr: new FormControl('', [Validators.required, Validators.maxLength(1000)]),
      descriptionEn: new FormControl('', [Validators.required, Validators.maxLength(1000)]),
      categoryId: new FormControl('', [Validators.required])
    })
  }
  onSubmit() {
    if (!this.productForm.valid) {
      return;
    }
    let productDto = this.productForm.value as CreateOrUpdateProductDto;
    this.productService.createProduct(productDto).subscribe(res => {
      if (res) {
        this.router.navigateByUrl('/products');
      }
    });
  }
  back() {
    this.router.navigateByUrl('/products');
  }
}
