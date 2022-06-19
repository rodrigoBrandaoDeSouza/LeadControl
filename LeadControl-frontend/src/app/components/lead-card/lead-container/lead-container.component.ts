import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lead-container',
  templateUrl: './lead-container.component.html',
  styleUrls: ['./lead-container.component.css']
})
export class LeadContainerComponent implements OnInit {

  constructor() { }

  
  ngOnInit(): void {
    const leads = 
    [
      {
        fullName: 'Rodrigo Brandão de Souza', 
        dataCreated: '19/06/2022', 
        sudurb: 'Panorama',
        category: '.NET Developer', 
        id: 123321, 
        description: "Desenvolver um teste", 
        price: 52.23, 
        status:''
      }, 
      {
        fullName: 'Ana Lucia Dourado', 
        dataCreated: '19/06/2022', 
        sudurb: 'Perto dos Lagos',
        category: 'Assistente Social', 
        id: 123321, 
        description: "Fazer o artigo", 
        price: 2350.00, 
        status:'acepted'
      },
      {
        fullName: 'Sandro Brandão da Silva', 
        dataCreated: '19/06/2022', 
        sudurb: 'Perto do Lago',
        category: 'Eletrecista', 
        id: 123321, 
        description: "puxar um fio", 
        price: 150.00,
        status: 'acepted' 
      },
      {
        fullName: 'Jão', 
        dataCreated: '19/06/2022', 
        sudurb: 'Perto da vó',
        category: 'Adm', 
        id: 123321, 
        description: "Proc+v", 
        price: 110.00,
        status: 'declined'
      }
    ]
  }
}
