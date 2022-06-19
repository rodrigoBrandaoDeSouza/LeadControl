import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-lead-container-invited',
  templateUrl: './lead-container-invited.component.html',
  styleUrls: ['./lead-container-invited.component.css']
})
export class LeadContainerInvitedComponent implements OnInit {
  @Input() leads!: any[];

  constructor() { }

  
  ngOnInit(): void {
  
  }
}
