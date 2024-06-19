import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from '../models/category';
import { environment } from 'src/environments/environment.dev';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  private apiUrl = `${environment.apiUrl}`;

  constructor(private http: HttpClient) { }

  getCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(`${this.apiUrl}/Categories`);
  }

  addCategory(category: Category): Observable<Category> {
    return this.http.post<Category>(`${this.apiUrl}/Categories/create`, category);
  }

  updateCategory(category: Category): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/Categories/${category.id}`, category);
  }
}
