import requests
from bs4 import BeautifulSoup

url1 = "https://otziv-otziv.ru/katalog/limonady-i-gazirovannye-napitki/coca-cola/gazirovannyy-napitok-coca-cola-classic.html?page=60"
url2 = "https://otziv-otziv.ru/katalog/limonady-i-gazirovannye-napitki/coca-cola/gazirovannyy-napitok-coca-cola-classic.html"

"""Парсинг всех отзывов, с 60 страницы """
response1 = requests.get(url1)
soup1 = BeautifulSoup(response1.content, "lxml")
reviews = soup1.find_all('div', 'container-reviews collapsible collapsed')
for review in reviews:
    print(review.get_text(strip=True, separator=' '))

"""Получить название товаров аналогов газированной воды Чупа-Чупса"""
response2 = requests.get(url2)
soup2 = BeautifulSoup(response2.content, "lxml")
names = soup2.find_all('h6')
print("\nТовары аналоги Газированный напиток Coca-Cola Classic:\n")
for i in range(len(names)):
    if "Coca" in names[i].get_text(strip=True, separator=' '):
        continue
    print("    " + names[i].get_text(strip=True, separator=' '))
