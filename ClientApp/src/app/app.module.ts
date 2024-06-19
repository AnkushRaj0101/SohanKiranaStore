import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BodyComponent } from './body/body.component';
import { SidenavComponent } from './sidenav/sidenav.component';
import { DashboardComponent } from './admin-components/dashboard/dashboard.component';
import { SettingsComponent } from './admin-components/settings/settings.component';
import { StatisticsComponent } from './admin-components/statistics/statistics.component';
import { BillingComponent } from './admin-components/billing/billing.component';
import { OrdersComponent } from './admin-components/orders/orders.component';
import { CustomersListComponent } from './admin-components/customers-list/customers-list.component';
import { CategoryComponent } from './admin-components/category/category.component';
import { ProductComponent } from './admin-components/product/product.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './home/home.component';
import { TopHeaderComponent } from './Common/top-header/top-header.component';
import { NavbarComponent } from './Common/navbar/navbar.component';
import { FooterComponent } from './Common/footer/footer.component';
import { TestimonialComponent } from './Common/testimonial/testimonial.component';
import { WhySohanKiranaComponent } from './Common/why-sohan-kirana/why-sohan-kirana.component';
import { CarouselComponent } from './Common/carousel/carousel.component';

@NgModule({
  declarations: [
    AppComponent,
    BodyComponent,
    SidenavComponent,
    DashboardComponent,
    StatisticsComponent,
    OrdersComponent,
    SettingsComponent,
    BillingComponent,
    OrdersComponent,
    CustomersListComponent,
    CategoryComponent,
    ProductComponent,
    HomeComponent,
    TopHeaderComponent,
    NavbarComponent,
    FooterComponent,
    TestimonialComponent,
    WhySohanKiranaComponent,
    CarouselComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
