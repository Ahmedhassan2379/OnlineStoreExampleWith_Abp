import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Products } from '@proxy';
import { ListProductsComponent } from './list-products/list-products.component';
import { AddProductComponent } from './add-product/add-product.component';

const routes: Routes = [
  {
    path:'add',
    pathMatch:'full',
    component:AddProductComponent
  },
  {
    path:'',
    pathMatch:'full',
    component:ListProductsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductsRoutingModule { }
