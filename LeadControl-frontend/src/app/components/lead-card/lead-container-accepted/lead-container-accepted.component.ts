import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-lead-container-accepted',
  templateUrl: './lead-container-accepted.component.html',
  styleUrls: ['./lead-container-accepted.component.css']
})
export class LeadContainerAcceptedComponent implements OnInit {
  @Input() leads!: any[];
  
  
  constructor() { }

  ngOnInit(): void {
  }
}
