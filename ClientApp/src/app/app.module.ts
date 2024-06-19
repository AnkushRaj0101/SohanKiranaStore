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
    ProductComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
