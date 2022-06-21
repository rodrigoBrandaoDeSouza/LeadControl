import { formatNumber } from '@angular/common';
import { Component, Input, OnInit, LOCALE_ID, Inject, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-lead-footer-invited',
  templateUrl: './lead-footer-invited.component.html',
  styleUrls: ['./lead-footer-invited.component.css']
})
export class LeadFooterInvitedComponent implements OnInit {
  @Output() AcceptClick = new EventEmitter();
  @Output() DeclineClick = new EventEmitter();
  @Input() lead!: any;
  

  constructor(@Inject(LOCALE_ID) public locale: string,) { }

  ngOnInit(): void {
  }

  formatPrice(price: any):string{
    return formatNumber(price, this.locale,'1.2-4').toString();
  }

  public ComponentAcceptEmit(){
    console.log(this.lead);
    this.AcceptClick.emit(this.lead.id);
  }
  public ComponentDeclineEmit(){
    console.log(this.lead);
    this.DeclineClick.emit(this.lead.id);
  }


}
