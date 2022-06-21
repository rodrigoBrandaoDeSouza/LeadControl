import { formatNumber } from '@angular/common';
import { Component, Inject, Input, OnInit,LOCALE_ID } from '@angular/core';

@Component({
  selector: 'app-lead-footer-accepted',
  templateUrl: './lead-footer-accepted.component.html',
  styleUrls: ['./lead-footer-accepted.component.css']
})
export class LeadFooterAcceptedComponent implements OnInit {

  @Input() lead!: any;
  
  constructor(@Inject(LOCALE_ID) public locale: string) { }

  ngOnInit(): void {
  }

  formatPrice(price: any):string{
    return formatNumber(price, this.locale,'1.2-4').toString();
  }

}
