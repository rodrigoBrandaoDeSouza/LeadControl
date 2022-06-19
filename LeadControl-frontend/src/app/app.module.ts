import { NgModule,LOCALE_ID } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTabsModule } from '@angular/material/tabs';
import { MatToolbarModule}  from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { LeadHeaderComponent } from './components/lead-card/lead-header/lead-header.component';
import { LeadBodyComponent } from './components/lead-card/lead-body/lead-body.component';
import { LeadFooterInvitedComponent } from './components/lead-card/lead-footer-invited/lead-footer-invited.component';
import { LeadContainerInvitedComponent } from './components/lead-card/lead-container-invited/lead-container-invited.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

import localept from '@angular/common/locales/pt';
import {registerLocaleData} from '@angular/common';
import { LeadContainerAcceptedComponent } from './components/lead-card/lead-container-accepted/lead-container-accepted.component';
import { LeadFooterAcceptedComponent } from './components/lead-card/lead-footer-accepted/lead-footer-accepted.component';
registerLocaleData(localept, 'pt');


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    LeadHeaderComponent,
    LeadBodyComponent,
    LeadFooterInvitedComponent,
    LeadContainerInvitedComponent,
    LeadContainerAcceptedComponent,
    LeadFooterAcceptedComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule, 
    MatTabsModule, 
    MatToolbarModule, 
    MatCardModule, 
    MatButtonModule,
    MatIconModule,
  ],
  providers: [{ provide: LOCALE_ID, useValue: "pt" }],
  bootstrap: [AppComponent]
})
export class AppModule { }
