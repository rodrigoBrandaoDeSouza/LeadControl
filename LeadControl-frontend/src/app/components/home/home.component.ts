import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { LeadService } from '../../services/lead-service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class HomeComponent implements OnInit {

  leadsInvited: any[] =[]
  leadsAccepted: any[] = []

  constructor(private readonly leadService: LeadService) {}
  
  ngOnInit(): void {
    this.getLeads();
  }

  public getLeads() {
    const paramsInvited= {
      'take':'100',
      'page':'1',
      'status':'invited'
    };

    this.leadService.getLeads(paramsInvited).subscribe((data) =>{
      this.leadsInvited = data;
    });

    const paramsAccepted= {
      'take':'100',
      'page':'1',
      'status':'Accepted'
    };

    this.leadService.getLeads(paramsAccepted).subscribe((data) =>{
      this.leadsAccepted = data;      
    });
  }

  public DeclineLeadClick(leadId: any){
    console.log("DECLINE"+leadId);
    const params:any = {
      "LeadId": leadId,
      "Status":"Declined"
    };
    this.leadService.updateLead(params).subscribe((data) =>{
      console.log(data);
    });
    this.refresh();
  }

  public AcceptLeadClick(leadId: any)  {
    
    const params:any = {
      "LeadId": leadId,
      "Status":"Accepted"
    };

    this.leadService.updateLead(params).subscribe((data) =>{
      console.log(data);
    });

    this.refresh(); 
  }

  refresh(): void {
    window.location.reload();
}
}
