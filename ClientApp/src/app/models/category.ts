export interface Category {
    id?: number;
    name: string;
    description: string;
    imageData:Blob;
    imageType:any;
  }
  
  // category.ts
export interface ProductSize {
  sizeId: number;
  description: string;
  price: number;
}

export interface ProductDescription {
  descriptionId: number;
  productDescription: string;
  features: string;
  otherProductInfo: string;
}

export interface Product {
  productId: number;
  name: string;
  sizes: ProductSize[];
  description: ProductDescription;
}


