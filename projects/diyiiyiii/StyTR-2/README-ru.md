# StyTr^2 : Перенос стиля изображения с помощью трансформеров (CVPR2022)
*Авторы: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

В этой работе предлагается метод для достижения непредвзятого переноса стиля изображения на основе модели трансформера. Наш подход позволяет улучшить эффект стилизации по сравнению с современными методами.
Этот репозиторий содержит официальную реализацию [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Представление результатов 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
По сравнению с некоторыми современными алгоритмами, наш метод обладает высокой способностью предотвращать утечку контента и обеспечивает лучшую способность представления признаков.  <br>


## Архитектура
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
Общий конвейер нашей архитектуры StyTr^2. Мы разбиваем контентные и стилевые изображения на патчи и используем линейное проецирование для получения последовательностей изображений. Затем контентные последовательности, дополненные CAPE, подаются на вход контентному трансформер-энкодеру, а стилевые последовательности — стилевому трансформер-энкодеру. После двух энкодеров применяется многоуровневый трансформер-декодер для стилизации контентных последовательностей в соответствии со стилевыми. В конце мы используем прогрессивный декодер с апсемплингом для получения стилизованных изображений с высоким разрешением.



## Эксперимент
### Требования
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Тестирование
Предобученные модели: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Пожалуйста, скачайте их и поместите в папку ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Обучение  
Датасет стиля — WikiArt, собранный с [WIKIART](https://www.wikiart.org/)  <br>  
Датасет контента — COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Ссылки
Если вы нашли нашу работу полезной для своих исследований, пожалуйста, цитируйте нашу статью, используя следующую запись BibTeX ~ Спасибо ^ . ^. Ссылка на статью [pdf](https://arxiv.org/abs/2105.14576)<br> 
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---