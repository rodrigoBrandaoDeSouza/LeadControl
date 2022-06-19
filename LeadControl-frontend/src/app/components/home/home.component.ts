import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class HomeComponent implements OnInit {

  leadsInvited: any[] = 
  [
    {
      fullName: 'Rodrigo Brandão de Souza', 
      dataCreated: '19/06/2022', 
      sudurb: 'Panorama',
      email: 'rodrigo@gmail.com',
      phone: '(45) 99994-7551',
      category: '.NET Developer', 
      id: 123321, 
      description: "Desenvolver um teste", 
      price: 52.23, 
      status:'invited'
    }, 
    {
      fullName: 'Ana Lucia Dourado', 
      dataCreated: '19/06/2022', 
      sudurb: 'Perto dos Lagos',
      email: 'ana@gmail.com',
      phone: '(45) 999534139',
      category: 'Assistente Social', 
      id: 123321, 
      description: "Fazer o artigo", 
      price: 2350.00, 
      status:'invited'
    }
  ]

  leadsAccepted: any[] = 
  [
    {
      fullName: 'Sandro Brandão da Silva', 
      dataCreated: '19/06/2022', 
      sudurb: 'Perto do Lago',
      email: 'sandro@gmail.com',
      phone: '(45) 99999999',
      category: 'Eletrecista', 
      id: 123321, 
      description: "puxar um fio", 
      price: 150.00,
      status: 'accepted' 
    },
    {
      fullName: 'Jão', 
      dataCreated: '19/06/2022', 
      sudurb: 'Perto da vó',
      email: 'jao@gmail.com',
      phone: '(45) 99999999',
      category: 'Adm', 
      id: 123321, 
      description: "Proc+v", 
      price: 110.00,
      status: 'accepted'
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
