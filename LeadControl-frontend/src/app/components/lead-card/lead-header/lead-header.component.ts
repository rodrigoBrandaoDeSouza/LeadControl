import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-lead-header',
  templateUrl: './lead-header.component.html',
  styleUrls: ['./lead-header.component.css']
})
export class LeadHeaderComponent implements OnInit {
  
  constructor() { }

  @Input() leads!: any[];

  ngOnInit(): void {

    const fullName = 'Rodrigo'
  }

}
