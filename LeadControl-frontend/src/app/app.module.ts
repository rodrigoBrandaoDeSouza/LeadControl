import { NgModule } from '@angular/core';
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
import { LeadFooterComponent } from './components/lead-card/lead-footer/lead-footer.component';
import { LeadContainerComponent } from './components/lead-card/lead-container/lead-container.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    LeadHeaderComponent,
    LeadBodyComponent,
    LeadFooterComponent,
    LeadContainerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule, 
    MatTabsModule, 
    MatToolbarModule, 
    MatCardModule, 
    MatButtonModule,
    MatIconModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
