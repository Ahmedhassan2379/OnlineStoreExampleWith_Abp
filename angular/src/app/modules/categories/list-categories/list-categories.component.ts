import { PagedAndSortedResultRequestDto, PagedResultRequestDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common'
import { CategoryService } from '@proxy/categories';
import { CategoryDto } from '@proxy/dtos';

@Component({
  selector: 'app-list-categories',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './list-categories.component.html',
  styleUrl: './list-categories.component.scss'
})
export class ListCategoriesComponent implements OnInit {

  categories :CategoryDto[]=[];
  input:PagedAndSortedResultRequestDto={sorting:'',maxResultCount:10,skipCount:0}
  constructor(private categoryService:CategoryService){

  }
  ngOnInit(): void {
    this.categoryService.getList(this.input).subscribe((response)=>{
      this.categories=response.items;
      console.log(response)
    })
    console.log('categories',this.categories);
  }
}
