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

  addCategory(category: Category,imageFile: File): Observable<Category> {
    console.log(imageFile);
    const formData = new FormData();
    formData.append('name', category.name);
    formData.append('description', category.description);
    formData.append('image', imageFile as Blob);
    
    console.log(formData);
    return this.http.post<Category>(`${this.apiUrl}/Categories/create`, formData);
  }

  updateCategory(category: Category): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/Categories/${category.id}`, category);
  }
}
