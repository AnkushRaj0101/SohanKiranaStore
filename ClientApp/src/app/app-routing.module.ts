import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './admin-components/dashboard/dashboard.component';
import { SettingsComponent } from './admin-components/settings/settings.component';
import { StatisticsComponent } from './admin-components/statistics/statistics.component';
import { BillingComponent } from './admin-components/billing/billing.component';
import { OrdersComponent } from './admin-components/orders/orders.component';
import { CustomersListComponent } from './admin-components/customers-list/customers-list.component';
import { ProductComponent } from './admin-components/product/product.component';
import { CategoryComponent } from './admin-components/category/category.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  {path: 'admin/dashboard', component: DashboardComponent},
  {path: 'admin/products', component: ProductComponent},
  {path: 'admin/statistics', component: StatisticsComponent},
  {path: 'admin/categories', component: CategoryComponent},
  {path: 'admin/billing', component: BillingComponent},
  {path: 'admin/orders', component: OrdersComponent},
  {path: 'admin/list', component: CustomersListComponent},
  {path: 'admin/settings', component: SettingsComponent},
  {path: 'home', component: HomeComponent},
  {path: 'admin/list', component: SettingsComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
