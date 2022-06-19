import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-lead-body',
  templateUrl: './lead-body.component.html',
  styleUrls: ['./lead-body.component.css']
})
export class LeadBodyComponent implements OnInit {
  @Input() lead!: any;
  constructor() { }

  ngOnInit(): void {
  }

}
