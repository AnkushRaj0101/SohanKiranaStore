import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/servcies/category.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss'],
  animations: [
    trigger('slideInOut', [
      state('in', style({ opacity: 1, transform: 'translateX(0)' })),
      transition(':enter', [
        style({ opacity: 0, transform: 'translateX(-100%)' }),
        animate('600ms ease-in-out')
      ]),
      transition(':leave', [
        animate('600ms ease-in-out', style({ opacity: 0, transform: 'translateX(-100%)' }))
      ])
    ])
  ]
})
export class CategoryComponent implements OnInit {
  categories: Category[] = [];
  selectedCategory: Category | null = null;
  newCategory: Category = { id: 0, name: '', description: '' };
  showForm = false;
  formMode: 'add' | 'edit' | null = null;

  constructor(private categoryService: CategoryService) {}

  ngOnInit(): void {
    this.loadCategories();
  }

  toggleForm(action: 'add' | 'edit', category?: Category): void {
    if (this.formMode === action && this.showForm) {
      this.showForm = false;
      this.formMode = null;
    } else {
      this.formMode = action;
      if (action === 'add') {
        this.selectedCategory = null;
        this.newCategory = { id: 0, name: '', description: '' };
      } else if (action === 'edit' && category) {
        this.selectedCategory = category;
        this.newCategory = { ...category }; // Copy category to form
      }
      this.showForm = true;
    }
  }

  loadCategories(): void {
    this.categoryService.getCategories().subscribe((categories) => {
      this.categories = categories;
    });
  }

  saveCategory(): void {
    if (this.selectedCategory) {
      this.categoryService.updateCategory(this.newCategory).subscribe(() => {
        this.loadCategories(); // Refresh the category list
        this.resetForm();
      });
    } else {
      this.categoryService.addCategory(this.newCategory).subscribe((category) => {
        this.categories.push(category);
        this.resetForm();
      });
    }
  }

  resetForm(): void {
    this.showForm = false;
    this.formMode = null;
    this.selectedCategory = null;
    this.newCategory = { id: 0, name: '', description: '' };
  }

  cancelForm(): void {
    this.resetForm();
  }
}