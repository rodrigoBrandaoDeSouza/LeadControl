import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-lead-container-invited',
  templateUrl: './lead-container-invited.component.html',
  styleUrls: ['./lead-container-invited.component.css']
})
export class LeadContainerInvitedComponent implements OnInit {
  @Output() AcceptLead = new EventEmitter();
  @Output() DeclineLead = new EventEmitter();
  @Input() leads!: any[];
  constructor() { }

  public AcceptLeadClick(leadId: any){
    this.AcceptLead.emit(leadId)
  }

  public DeclineLeadClick(leadId: any){
    this.DeclineLead.emit(leadId)
  }

  ngOnInit(): void {
  }
}
