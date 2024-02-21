from django import forms
from django.contrib.auth.models import User
from django.contrib.auth.forms import UserCreationForm
from django.utils.translation import gettext_lazy as _

class RegisterForm(UserCreationForm):
    class Meta:
        model = User
        username = forms.CharField(label=_('نام کاربری'))
        email = forms.CharField(label=_('ایمیل'))
        fields = ['username', 'email', 'password1', 'password2']
