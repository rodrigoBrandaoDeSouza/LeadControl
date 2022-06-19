import { formatNumber } from '@angular/common';
import { Component, Input, OnInit, LOCALE_ID, Inject } from '@angular/core';

@Component({
  selector: 'app-lead-footer-invited',
  templateUrl: './lead-footer-invited.component.html',
  styleUrls: ['./lead-footer-invited.component.css']
})
export class LeadFooterInvitedComponent implements OnInit {
  @Input() lead!: any;
  constructor(@Inject(LOCALE_ID) public locale: string,) { }

  ngOnInit(): void {
  }

  formatPrice(price: any):string{
    return formatNumber(price, this.locale,'1.2-4').toString();
  }

}
