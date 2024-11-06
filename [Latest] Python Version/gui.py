import tkinter as tk
from tkinter import ttk
from tkinter import PhotoImage
from threading import Thread
from pathlib import Path
import tempfile
import requests
import os
import ctypes
import sys
import subprocess
import webbrowser

# Admin Elevation
def run_as_admin():
    if not ctypes.windll.shell32.IsUserAnAdmin():
        ctypes.windll.shell32.ShellExecuteW(None, "runas", sys.executable, ' '.join([f'"{arg}"' for arg in sys.argv]), None, 1)
        sys.exit()
run_as_admin()
start = tk.Tk()
start.geometry('480x500')
start.resizable(False, False)
start.attributes('-alpha', 0.9)
start.title('DRP Tweaker')
script_path = os.path.abspath(__file__)
script_dir = os.path.dirname(script_path)
icon = PhotoImage(file=script_dir + "/assets/icon.png")
start.iconphoto(False, icon) 


# Cloudflare 1.1.1.1
def cloud():
    url = 'https://1111-releases.cloudflareclient.com/win/latest'
    response = requests.get(url, stream=True)
    filename = 'Cloudflare.msi'
    file_path = Path(tempfile.gettempdir()) / filename
    
    d = Path(tempfile.gettempdir())
    print(f'Downloading {filename} to {d}')
    
    with open(file_path, 'wb') as f:
        for chunk in response.iter_content(chunk_size=8192):
         if chunk:
              f.write(chunk)
    
    process = subprocess.Popen([str(file_path)], shell=True)
    process.wait()
    print(f"Running Cloudflare Installer completed successfully!")

    if process.returncode != 0:
        os.remove(file_path)
def start_cloudflare():
    thread = Thread(target=cloud)
    thread.start()


# Malwarebytes
def malwarebytes():
    url = 'https://downloads.malwarebytes.com/file/mb-windows'
    response = requests.get(url, stream=True)
    filename = 'Malwarebytes.exe'
    file_path = Path(tempfile.gettempdir()) / filename
    
    temp = Path(tempfile.gettempdir())
    print(f'Downloading {filename} to {temp}')
    
    with open(file_path, 'wb') as f:
        for chunk in response.iter_content(chunk_size=8192):
         if chunk:
              f.write(chunk)

    process = subprocess.Popen([str(file_path)], shell=True)
    process.wait()
    print(f"Running MalwareBytes Installer completed successfully!")

    if process.returncode != 0:
        os.remove(file_path)
    
def start_malwarebytes():
    thread = Thread(target=malwarebytes)
    thread.start()




# Arc Browser
def arc():
    url = 'https://releases.arc.net/windows/ArcInstaller.exe'
    response = requests.get(url, stream=True)
    filename = 'Arc_Installer.exe'
    file_path = Path(tempfile.gettempdir()) / filename
    
    temp = Path(tempfile.gettempdir())
    print(f'Downloading {filename} to {temp}')
    
    with open(file_path, 'wb') as f:
        for chunk in response.iter_content(chunk_size=8192):
         if chunk:
              f.write(chunk)
    

    process = subprocess.Popen([str(file_path)], shell=True)
    process.wait()
    print(f"Running Arc Installer completed successfully!")
    
    if process.returncode != 0:
        os.remove(file_path)
def start_arc():
    thread = Thread(target=arc)
    thread.start()


# Functions Of Scripts 
def dns_runner():
    os.system('"netsh interface ip add dns name="Ethernet" addr=1.1.1.2"')
    os.system('"netsh interface ip add dns name="Ethernet" addr=1.0.0.2 index=2"')
    os.system('"netsh interface ipv6 add dnsserver "Ethernet" 2606:4700:4700::1112"')
    os.system('"ipconfig /flushdns"')
    
def win_activate():
    subprocess.Popen(["powershell.exe", "irm https://get.activated.win | iex"], stdout=sys.stdout)

def perfomance_power():
    subprocess.run(["powercfg", "/setactive", "e9a42b02-d5df-448d-aa00-03f14749eb61"], check=True)

# Github Redirection
github_icon = PhotoImage(file=script_dir + "/assets/github.png")
github_icon = github_icon.subsample(40, 40)

# Labels
tk.Label(
    start, 
    text="Programs", 
    font=("Arial", 15),
    width=15,
    padx=5, 
    pady=20
).grid(row=0, column=0)

tk.Label(
    start,
    text="Scripts",
    font=("Arial", 15),
    width=15,
).grid(column=2, row=0)



# Buttons
ttk.Button(
    start, 
    text="Cloudflare", 
    command=start_cloudflare,
    width=20,
    padding=(10, 20),
    cursor="hand2",
).grid(row=1)

ttk.Button(
    start,
    text="Malwarebytes", 
    command=start_malwarebytes,
    width=20,
    padding=(10, 20),
    cursor="hand2",
).grid(row=2)

ttk.Button(
    start,
    text="Arc Browser", 
    command=start_arc,
    width=20,
    padding=(10, 20),
    cursor="hand2",
).grid(row=3)
    
# Scripts
ttk.Button(
    start,
    text="Cloudflare DNS",
    width=20,
    command=dns_runner,
    padding=(10, 20),
    cursor="hand2",
).grid(row=1, column=2)

ttk.Button(
    start,
    text="Activate Win10/11",
    width=20,
    command=win_activate,
    padding=(10, 20),
    cursor="hand2",
).grid(row=2, column=2)

ttk.Button(
    start,
    text="Perfomance Power",
    width=20,
    command=perfomance_power,
    padding=(10, 20),
    cursor="hand2",
).grid(row=3, column=2)

github = ttk.Label(
    start,
    image=github_icon,
    cursor="hand2"
)
github.bind('<Button-1>', lambda e: webbrowser.open('https://github.com/DrPanayioths/DRP-Tweaker'))
github.grid(row=0, column=1, padx=40, sticky='nsew')






start.mainloop()
