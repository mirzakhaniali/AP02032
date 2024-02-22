from django.urls import path
from . import views

urlpatterns = [
    path('sabtenam/', views.sign_up, name='sabtenam'),
    path('emtehani/', views.emtehani, name='sabtenam'),
]