import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-lead-header',
  templateUrl: './lead-header.component.html',
  styleUrls: ['./lead-header.component.css']
})
export class LeadHeaderComponent implements OnInit {
  @Input()
  lead!: any;

  constructor() { }
  ngOnInit(): void {

  }

  getFirstCharacter(word: string): string{
    return word.substring(0,1)
  }
}
