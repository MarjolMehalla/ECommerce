import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { PageHeaderComponent } from './components/page-header/page-header.component';
import { PagerComponent } from './components/pager/pager.component';



@NgModule({
  declarations: [PageHeaderComponent, PagerComponent],
  imports: [
    CommonModule,
    PaginationModule.forRoot()
  ],
  exports : [
    PaginationModule,
    PageHeaderComponent,
    PagerComponent
  ]
})
export class SharedModule { }
