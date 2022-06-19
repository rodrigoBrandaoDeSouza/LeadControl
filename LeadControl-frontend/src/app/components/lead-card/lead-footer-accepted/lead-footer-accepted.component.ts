import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-lead-footer-accepted',
  templateUrl: './lead-footer-accepted.component.html',
  styleUrls: ['./lead-footer-accepted.component.css']
})
export class LeadFooterAcceptedComponent implements OnInit {

  @Input() lead!: any;
  
  constructor() { }

  ngOnInit(): void {
  }

}
