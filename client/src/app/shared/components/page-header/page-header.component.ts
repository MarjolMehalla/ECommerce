import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-page-header',
  templateUrl: './page-header.component.html',
  styleUrls: ['./page-header.component.scss']
})
export class PageHeaderComponent implements OnInit {
@Input() pageIndex: number;
@Input() pageSize: number;
@Input() totalCount: number;
  constructor() { }

  ngOnInit(): void {
  }

}
