﻿# WeatherScrapper.py
# Language: Python 3.0
# This script runs a web scrapper returns
# current weather information from requested URL
# January 2022 - March 2022
from bs4 import BeautifulSoup
import requests
import sys

# currently, freeweather.com only works with the united states
# url to scrape weather data from
try:
    # build url from location.txt
    with open('..\..\WeatherNode\PythonScripts\location.txt', 'r') as file:
        # all weather locations have this beginning url
        url_beg = 'https://www.freeweather.com/cgi-bin/weather/weather.cgi?place='
        # city has format ex: NEW+YORK+CITY
        url_city = file.readline().upper().replace(' ','+').rstrip('\n')
        # state has format ex: &state=ny
        url_state = '&state=' + file.readline().lower().rstrip('\n')
        url = url_beg + url_city + url_state
# if locations.txt cannot be read, then exit
except Exception:
    sys.exit("ERROR: Could not open location.txt\n")

# employ beautifulsoup to scrape data
page = requests.get(url)
soup = BeautifulSoup(page.content, "html.parser")

# get current weather container
weather = soup.find('div', class_='shadetabs3')
# find all the weather fields within the container
weather_elements = weather.find_all("div", class_="bottomline")

# get forecasted weather container
weather_forecast = soup.find_all('div', class_= 'shadetabs3', limit=2)
# get forecasted weather fields within the container
weather_forecast_elements = weather_forecast[1]

with open('..\PythonScripts\htmlparse.txt', 'w') as file:
    x = 0
    # write container that has location name
    file.write(weather.find('div', class_='fptitle2').text.strip()+'\n')
    # write weather information to file
    for weather_elements in weather_elements:
        file.write(weather_elements.text.strip())
        # used for formatting text file
        x += 1
        if x % 2 == 0:
            file.write('\n')
            x = 0
    # save URL to file
    file.write('URL:'+ url+ '\n')
    x = 0
    # writes forecasted weather (partly cloudy, rainy, etc.)
    for weather_forecast_elements in weather_forecast_elements:
        if (x == 3): # only interested in whats is in the 3rd element
            file.write(weather_forecast_elements.text.strip() + '\n')
        else:
            pass
        x += 1