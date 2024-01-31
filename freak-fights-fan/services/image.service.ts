import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { GetAllImages } from '../shared/features/images/queries/GetAllImages';
import { Observable } from 'rxjs/internal/Observable';
import { PagedList } from '../shared/abstractions/PagedList';
import { FighterDto } from '../shared/features/fighters/responses/FighterDto';
import { ImageDto } from '../shared/features/images/responses/ImageDto';
import { CreateImage } from '../shared/features/images/commands/CreateImage';
import { UpdateImage } from '../shared/features/images/commands/UpdateImage';

@Injectable({
  providedIn: 'root'
})
export class ImageService {
  url = "api/images";

  constructor(private apiService: ApiService) { }

  getAllImages(query: GetAllImages.Query): Observable<PagedList<FighterDto>> {
    return this.apiService.postWithResponse<GetAllImages.Query, PagedList<FighterDto>>(`${this.url}/all`, query);
  }

  getImage(id: number): Observable<ImageDto> {
    return this.apiService.get<ImageDto>(`${this.url}/${id}`);
  }

  createImage(command: CreateImage.Command) {
    return this.apiService.post(this.url, command);
  }

  updateImage(command: UpdateImage.Command) {
    return this.apiService.put(`${this.url}/${command.id}`, command);
  }

  deleteImage(id: number) {
    return this.apiService.delete(`${this.url}/${id}`);
  }
}
