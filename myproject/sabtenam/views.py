from django.shortcuts import render, redirect
from django.contrib.auth.forms import UserCreationForm

def sign_up(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            form.save()
            # Redirect to login page or any other desired page
            return redirect('login') # ino hanoo naneveshtam
    else:
        form = UserCreationForm()
    return render(request, 'sabtenam/safhe_sabtenam.html', {'form': form})
